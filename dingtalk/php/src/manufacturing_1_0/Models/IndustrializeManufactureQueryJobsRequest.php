<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustrializeManufactureQueryJobsRequest extends Model
{
    /**
     * @description 产品中文名称
     *
     * @var string
     */
    public $productName;

    /**
     * @description 每页显示记录条数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 报工合格数量
     *
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @description 生产日期
     *
     * @var string
     */
    public $manufactureDay;

    /**
     * @description 工单编号
     *
     * @var string
     */
    public $instNo;

    /**
     * @description 员工姓名
     *
     * @var string
     */
    public $userName;

    /**
     * @description 产品唯一标识
     *
     * @var string
     */
    public $productCode;

    /**
     * @description 产品规格
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @description 计件单价，单位：分
     *
     * @var string
     */
    public $unitPrice;

    /**
     * @description 报工记录的唯一标识
     *
     * @var string
     */
    public $uuid;

    /**
     * @description 当前页序号(从1开始)
     *
     * @var int
     */
    public $currentPage;

    /**
     * @description 员工钉钉userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description MES系统唯一标识
     *
     * @var string
     */
    public $mesAppKey;
    protected $_name = [
        'productName'          => 'productName',
        'pageSize'             => 'pageSize',
        'qualifiedQuantity'    => 'qualifiedQuantity',
        'manufactureDay'       => 'manufactureDay',
        'instNo'               => 'instNo',
        'userName'             => 'userName',
        'productCode'          => 'productCode',
        'productSpecification' => 'productSpecification',
        'unitPrice'            => 'unitPrice',
        'uuid'                 => 'uuid',
        'currentPage'          => 'currentPage',
        'userId'               => 'userId',
        'mesAppKey'            => 'mesAppKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->qualifiedQuantity) {
            $res['qualifiedQuantity'] = $this->qualifiedQuantity;
        }
        if (null !== $this->manufactureDay) {
            $res['manufactureDay'] = $this->manufactureDay;
        }
        if (null !== $this->instNo) {
            $res['instNo'] = $this->instNo;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->productSpecification) {
            $res['productSpecification'] = $this->productSpecification;
        }
        if (null !== $this->unitPrice) {
            $res['unitPrice'] = $this->unitPrice;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->currentPage) {
            $res['currentPage'] = $this->currentPage;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->mesAppKey) {
            $res['mesAppKey'] = $this->mesAppKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustrializeManufactureQueryJobsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['qualifiedQuantity'])) {
            $model->qualifiedQuantity = $map['qualifiedQuantity'];
        }
        if (isset($map['manufactureDay'])) {
            $model->manufactureDay = $map['manufactureDay'];
        }
        if (isset($map['instNo'])) {
            $model->instNo = $map['instNo'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['productSpecification'])) {
            $model->productSpecification = $map['productSpecification'];
        }
        if (isset($map['unitPrice'])) {
            $model->unitPrice = $map['unitPrice'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['currentPage'])) {
            $model->currentPage = $map['currentPage'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['mesAppKey'])) {
            $model->mesAppKey = $map['mesAppKey'];
        }

        return $model;
    }
}
