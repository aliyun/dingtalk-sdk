<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustrializeManufactureJobBookRequest extends Model
{
    /**
     * @description 钉钉组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 扩展字段，用于增加自定义字段
     *
     * @var string
     */
    public $extend;

    /**
     * @description 工单编号
     *
     * @var string
     */
    public $instNo;

    /**
     * @description 是否是批量报工(取值[n,y])
     *
     * @var string
     */
    public $isBatchJob;

    /**
     * @description 生产日期时间(到时分秒)
     *
     * @var string
     */
    public $manufactureDate;

    /**
     * @description mes 系统唯一标识
     *
     * @var string
     */
    public $mesAppKey;

    /**
     * @description 制程英文名称
     *
     * @var string
     */
    public $processEnName;

    /**
     * @description 制程名称
     *
     * @var string
     */
    public $processName;

    /**
     * @description 产品唯一标识
     *
     * @var string
     */
    public $productCode;

    /**
     * @description 产品英文名称
     *
     * @var string
     */
    public $productEnName;

    /**
     * @description 产品名称，例如"双头螺柱001"
     *
     * @var string
     */
    public $productName;

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
     * @description 报废数量
     *
     * @var string
     */
    public $scrappedQuantity;

    /**
     * @description 计件单价，单位：分
     *
     * @var string
     */
    public $unitPrice;

    /**
     * @description 批量报工时多个工人userId以英文逗号分隔
     *
     * @var string
     */
    public $userIdList;

    /**
     * @description 员工姓名
     *
     * @var string
     */
    public $userName;

    /**
     * @description 批量报工时多个人名以英文逗号分隔
     *
     * @var string
     */
    public $userNameList;

    /**
     * @description 随机串，唯一标识(用于幂等及更新)
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'corpId'               => 'corpId',
        'extend'               => 'extend',
        'instNo'               => 'instNo',
        'isBatchJob'           => 'isBatchJob',
        'manufactureDate'      => 'manufactureDate',
        'mesAppKey'            => 'mesAppKey',
        'processEnName'        => 'processEnName',
        'processName'          => 'processName',
        'productCode'          => 'productCode',
        'productEnName'        => 'productEnName',
        'productName'          => 'productName',
        'productSpecification' => 'productSpecification',
        'qualifiedQuantity'    => 'qualifiedQuantity',
        'reworkableQuantity'   => 'reworkableQuantity',
        'scrappedQuantity'     => 'scrappedQuantity',
        'unitPrice'            => 'unitPrice',
        'userIdList'           => 'userIdList',
        'userName'             => 'userName',
        'userNameList'         => 'userNameList',
        'uuid'                 => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->instNo) {
            $res['instNo'] = $this->instNo;
        }
        if (null !== $this->isBatchJob) {
            $res['isBatchJob'] = $this->isBatchJob;
        }
        if (null !== $this->manufactureDate) {
            $res['manufactureDate'] = $this->manufactureDate;
        }
        if (null !== $this->mesAppKey) {
            $res['mesAppKey'] = $this->mesAppKey;
        }
        if (null !== $this->processEnName) {
            $res['processEnName'] = $this->processEnName;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->productEnName) {
            $res['productEnName'] = $this->productEnName;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
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
        if (null !== $this->scrappedQuantity) {
            $res['scrappedQuantity'] = $this->scrappedQuantity;
        }
        if (null !== $this->unitPrice) {
            $res['unitPrice'] = $this->unitPrice;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->userNameList) {
            $res['userNameList'] = $this->userNameList;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['instNo'])) {
            $model->instNo = $map['instNo'];
        }
        if (isset($map['isBatchJob'])) {
            $model->isBatchJob = $map['isBatchJob'];
        }
        if (isset($map['manufactureDate'])) {
            $model->manufactureDate = $map['manufactureDate'];
        }
        if (isset($map['mesAppKey'])) {
            $model->mesAppKey = $map['mesAppKey'];
        }
        if (isset($map['processEnName'])) {
            $model->processEnName = $map['processEnName'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['productEnName'])) {
            $model->productEnName = $map['productEnName'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
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
        if (isset($map['scrappedQuantity'])) {
            $model->scrappedQuantity = $map['scrappedQuantity'];
        }
        if (isset($map['unitPrice'])) {
            $model->unitPrice = $map['unitPrice'];
        }
        if (isset($map['userIdList'])) {
            $model->userIdList = $map['userIdList'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['userNameList'])) {
            $model->userNameList = $map['userNameList'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
