<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAbandonStatusRequest\blueGeneralInvoiceVO;

use AlibabaCloud\Tea\Model;

class vehicleSaleDetailVOList extends Model
{
    /**
     * @description 品牌
     *
     * @var string
     */
    public $brand;

    /**
     * @description 合格证号
     *
     * @var string
     */
    public $certificateNo;

    /**
     * @description 发动机号
     *
     * @var string
     */
    public $engineNo;

    /**
     * @description 身份证号/组织机构代码
     *
     * @var string
     */
    public $idCardNo;

    /**
     * @description 进口证书号
     *
     * @var string
     */
    public $importCertificateNo;

    /**
     * @var string
     */
    public $inspectionListNo;

    /**
     * @description 限乘人数
     *
     * @var string
     */
    public $maxPassengers;

    /**
     * @description 产地
     *
     * @var string
     */
    public $originPlace;

    /**
     * @description 完税凭证号码
     *
     * @var string
     */
    public $paymentVoucherNo;

    /**
     * @description 主管税务机关名称
     *
     * @var string
     */
    public $taxAuthorityName;

    /**
     * @description 主管税务机关代码
     *
     * @var string
     */
    public $taxAuthorityNo;

    /**
     * @description 税率
     *
     * @var string
     */
    public $taxRate;

    /**
     * @description 吨位
     *
     * @var string
     */
    public $tonnage;

    /**
     * @description 车架号码
     *
     * @var string
     */
    public $vehicleNo;

    /**
     * @description 车辆类型
     *
     * @var string
     */
    public $vehicleType;
    protected $_name = [
        'brand'               => 'brand',
        'certificateNo'       => 'certificateNo',
        'engineNo'            => 'engineNo',
        'idCardNo'            => 'idCardNo',
        'importCertificateNo' => 'importCertificateNo',
        'inspectionListNo'    => 'inspectionListNo',
        'maxPassengers'       => 'maxPassengers',
        'originPlace'         => 'originPlace',
        'paymentVoucherNo'    => 'paymentVoucherNo',
        'taxAuthorityName'    => 'taxAuthorityName',
        'taxAuthorityNo'      => 'taxAuthorityNo',
        'taxRate'             => 'taxRate',
        'tonnage'             => 'tonnage',
        'vehicleNo'           => 'vehicleNo',
        'vehicleType'         => 'vehicleType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->brand) {
            $res['brand'] = $this->brand;
        }
        if (null !== $this->certificateNo) {
            $res['certificateNo'] = $this->certificateNo;
        }
        if (null !== $this->engineNo) {
            $res['engineNo'] = $this->engineNo;
        }
        if (null !== $this->idCardNo) {
            $res['idCardNo'] = $this->idCardNo;
        }
        if (null !== $this->importCertificateNo) {
            $res['importCertificateNo'] = $this->importCertificateNo;
        }
        if (null !== $this->inspectionListNo) {
            $res['inspectionListNo'] = $this->inspectionListNo;
        }
        if (null !== $this->maxPassengers) {
            $res['maxPassengers'] = $this->maxPassengers;
        }
        if (null !== $this->originPlace) {
            $res['originPlace'] = $this->originPlace;
        }
        if (null !== $this->paymentVoucherNo) {
            $res['paymentVoucherNo'] = $this->paymentVoucherNo;
        }
        if (null !== $this->taxAuthorityName) {
            $res['taxAuthorityName'] = $this->taxAuthorityName;
        }
        if (null !== $this->taxAuthorityNo) {
            $res['taxAuthorityNo'] = $this->taxAuthorityNo;
        }
        if (null !== $this->taxRate) {
            $res['taxRate'] = $this->taxRate;
        }
        if (null !== $this->tonnage) {
            $res['tonnage'] = $this->tonnage;
        }
        if (null !== $this->vehicleNo) {
            $res['vehicleNo'] = $this->vehicleNo;
        }
        if (null !== $this->vehicleType) {
            $res['vehicleType'] = $this->vehicleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return vehicleSaleDetailVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['brand'])) {
            $model->brand = $map['brand'];
        }
        if (isset($map['certificateNo'])) {
            $model->certificateNo = $map['certificateNo'];
        }
        if (isset($map['engineNo'])) {
            $model->engineNo = $map['engineNo'];
        }
        if (isset($map['idCardNo'])) {
            $model->idCardNo = $map['idCardNo'];
        }
        if (isset($map['importCertificateNo'])) {
            $model->importCertificateNo = $map['importCertificateNo'];
        }
        if (isset($map['inspectionListNo'])) {
            $model->inspectionListNo = $map['inspectionListNo'];
        }
        if (isset($map['maxPassengers'])) {
            $model->maxPassengers = $map['maxPassengers'];
        }
        if (isset($map['originPlace'])) {
            $model->originPlace = $map['originPlace'];
        }
        if (isset($map['paymentVoucherNo'])) {
            $model->paymentVoucherNo = $map['paymentVoucherNo'];
        }
        if (isset($map['taxAuthorityName'])) {
            $model->taxAuthorityName = $map['taxAuthorityName'];
        }
        if (isset($map['taxAuthorityNo'])) {
            $model->taxAuthorityNo = $map['taxAuthorityNo'];
        }
        if (isset($map['taxRate'])) {
            $model->taxRate = $map['taxRate'];
        }
        if (isset($map['tonnage'])) {
            $model->tonnage = $map['tonnage'];
        }
        if (isset($map['vehicleNo'])) {
            $model->vehicleNo = $map['vehicleNo'];
        }
        if (isset($map['vehicleType'])) {
            $model->vehicleType = $map['vehicleType'];
        }

        return $model;
    }
}
