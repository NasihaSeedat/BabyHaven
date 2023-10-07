<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Frontend.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Contact Section Begin -->
    <section class="contact spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6">
                    <div class="contact__content">
                        <div class="contact__address">
                            <h5>About Us</h5>
                            <p>We at BabyHaven aim to make this website accessible for parents and caregivers. We offer a wide range of baby items and
                            accessories. Our goal is to make baby shopping simple and enjoyable, providing a
                            convenient and easy online experience. From high-quality clothing, toys, feeding essentials,
                            to nursery furniture, we have everything your baby needs.
                            </p>
                            <h5>Contact info</h5>
                            <ul>
                                <li>
                                    <h6><i class="fa fa-map-marker"></i> Address</h6>
                                    <p>University of Johannesburg</p>
                                </li>
                                <li>
                                    <h6><i class="fa fa-phone"></i> Phone</h6>
                                    <p><span>011-234-5678</span><span>011-987-4562</span></p>
                                </li>
                                <li>
                                    <h6><i class="fa fa-headphones"></i> Support</h6>
                                    <p><a href="mailto:babyhavenproject@gmail.com">babyhavenproject@gmail.com</a></p>
                                </li>
                            </ul>
                        </div>
                    <%--    <div class="contact__form">
                            <h5>SEND MESSAGE</h5>
                            <form action="#">
                                <input type="text" placeholder="Name">
                                <input type="text" placeholder="Email">
                                <input type="text" placeholder="Website">
                                <textarea placeholder="Message"></textarea>
                                <button type="submit" class="site-btn">Send Message</button>
                            </form>
                        </div>--%>
                    </div>
                </div>
                <div class="col-lg-6 col-md-6">
                    <div class="contact__map">
                        <iframe
                        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3579.4169594562995!2d28.009124115325353!3d-26.18312028345953!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1e950db9bf071c57%3A0xfb7d187ee11cb674!2s10%20Ditton%20Ave%2C%20Rossmore%2C%20Johannesburg%2C%202092!5e0!3m2!1sen!2sza!4v1630670585321!5m2!1sen!2sza"
                        height="780" style="border:0" allowfullscreen="">
                        </iframe>
                    </div>
                </div>
            </div>
        </div>
    </section>
<!-- Contact Section End -->

</asp:Content>
