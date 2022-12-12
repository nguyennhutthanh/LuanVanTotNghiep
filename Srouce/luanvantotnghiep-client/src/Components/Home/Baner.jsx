import React from 'react';
import OwlCarousel from 'react-owl-carousel';
import 'owl.carousel/dist/assets/owl.carousel.css';
import 'owl.carousel/dist/assets/owl.theme.default.css';

const Baner = () => {
    const options = {
        loop: true,
        margin: 10,
        items: 1,
        autoplay: true
    };
    return (
        <div className="tab-content">
            <OwlCarousel className="owl-carousel owl-theme" {...options} nav>
                <div className="caroseo-ne">
                    <div className="item">
                        <a href="#">
                            <img src="img/home/home4-slide1.jpg" alt="img" />
                        </a>
                    </div>
                </div>
                <div className="caroseo-ne">
                    <div className="item">
                        <a href="#">
                            <img src="img/home/home4-slide2.jpg" alt="img" />
                        </a>
                    </div>
                </div>
                <div className="caroseo-ne">
                    <div className="item">
                        <a href="#">
                            <img src="img/home/home4-slide3.jpg" alt="img" />
                        </a>
                    </div>
                </div>
            </OwlCarousel>
        </div>
    );
};

export default Baner;