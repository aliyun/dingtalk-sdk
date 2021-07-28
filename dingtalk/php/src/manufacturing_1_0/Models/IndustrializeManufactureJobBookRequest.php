<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustrializeManufactureJobBookRequest extends Model
{
    /**
     * @description 报废数量
     *
     * @var string
     */
    public $scrappedQuantity;

    /**
     * @description 产品规格
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @description 合格数量
     *
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @description 可重工数量
     *
     * @var string
     */
    public $reworkableQuantity;

    /**
     * @description 员工姓名
     *
     * @var string
     */
    public $userName;

    /**
     * @description 随机串，唯一标识(用于幂等及更新)
     *
     * @var string
     */
    public $uuid;

    /**
     * @description 产品名称，例如"双头螺柱001"
     *
     * @var string
     */
    public $productName;

    /**
     * @description 产品英文名称
     *
     * @var string
     */
    public $productEnName;

    /**
     * @description 扩展字段，用于增加自定义字段
     *
     * @var string
     */
    public $extend;

    /**
     * @description 产品唯一标识
     *
     * @var string
     */
    public $productCode;

    /**
     * @description 制程名称
     *
     * @var string
     */
    public $processName;

    /**
     * @description 制程英文名称
     *
     * @var string
     */
    public $processEnName;

    /**
     * @description mes 系统唯一标识
     *
     * @var string
     */
    public $mesAppKey;

    /**
     * @description 工单编号
     *
     * @var string
     */
    public $instNo;

    /**
     * @description 生产日期时间(到时分秒)
     *
     * @var string
     */
    public $manufactureDate;

    /**
     * @description 钉钉组织id
     *
     * @var string
     */
    public $dingCorpId;
    protected $_name = [
        'scrappedQuantity'     => 'scrappedQuantity',
        'productSpecification' => 'productSpecification',
        'qualifiedQuantity'    => 'qualifiedQuantity',
        'reworkableQuantity'   => 'reworkableQuantity',
        'userName'             => 'userName',
        'uuid'                 => 'uuid',
        'productName'          => 'productName',
        'productEnName'        => 'productEnName',
        'extend'               => 'extend',
        'productCode'          => 'productCode',
        'processName'          => 'processName',
        'processEnName'        => 'processEnName',
        'mesAppKey'            => 'mesAppKey',
        'instNo'               => 'instNo',
        'manufactureDate'      => 'manufactureDate',
        'dingCorpId'           => 'dingCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scrappedQuantity) {
            $res['scrappedQuantity'] = $this->scrappedQuantity;
        }
        if (null !== $this->productSpecification) {
            $res['productSpecification'] = $this->productSpecification;
        }
        if (null !== $this->qualifiedQuantity) {
            $res['qualifiedQuantity'] = $this->qualifiedQuantity;
        }
        if (null !== $this->reworkableQuantity) {
            $res['reworkableQuantity'] = $this->reworkableQuantity;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->productEnName) {
            $res['productEnName'] = $this->productEnName;
        }
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->processEnName) {
            $res['processEnName'] = $this->processEnName;
        }
        if (null !== $this->mesAppKey) {
            $res['mesAppKey'] = $this->mesAppKey;
        }
        if (null !== $this->instNo) {
            $res['instNo'] = $this->instNo;
        }
        if (null !== $this->manufactureDate) {
            $res['manufactureDate'] = $this->manufactureDate;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustrializeManufactureJobBookRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scrappedQuantity'])) {
            $model->scrappedQuantity = $map['scrappedQuantity'];
        }
        if (isset($map['productSpecification'])) {
            $model->productSpecification = $map['productSpecification'];
        }
        if (isset($map['qualifiedQuantity'])) {
            $model->qualifiedQuantity = $map['qualifiedQuantity'];
        }
        if (isset($map['reworkableQuantity'])) {
            $model->reworkableQuantity = $map['reworkableQuantity'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['productEnName'])) {
            $model->productEnName = $map['productEnName'];
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['processEnName'])) {
            $model->processEnName = $map['processEnName'];
        }
        if (isset($map['mesAppKey'])) {
            $model->mesAppKey = $map['mesAppKey'];
        }
        if (isset($map['instNo'])) {
            $model->instNo = $map['instNo'];
        }
        if (isset($map['manufactureDate'])) {
            $model->manufactureDate = $map['manufactureDate'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }

        return $model;
    }
}
