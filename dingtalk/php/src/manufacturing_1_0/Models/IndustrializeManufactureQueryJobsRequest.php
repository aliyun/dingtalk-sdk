<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustrializeManufactureQueryJobsRequest extends Model
{
    /**
     * @description 当前页序号(从1开始)
     *
     * @var int
     */
    public $currentPage;

    /**
     * @description 工单编号
     *
     * @var string
     */
    public $instNo;

    /**
     * @description 生产日期
     *
     * @var string
     */
    public $manufactureDay;

    /**
     * @description MES系统唯一标识
     *
     * @var string
     */
    public $mesAppKey;

    /**
     * @description 每页显示记录条数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 工序名称
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
     * @description 产品中文名称
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
     * @description 报工合格数量
     *
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @description 计件单价，单位：分
     *
     * @var string
     */
    public $unitPrice;

    /**
     * @description 员工钉钉userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 批量报工时多个人钉钉工号以英文逗号分隔
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
     * @description 报工记录的唯一标识
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'currentPage'          => 'currentPage',
        'instNo'               => 'instNo',
        'manufactureDay'       => 'manufactureDay',
        'mesAppKey'            => 'mesAppKey',
        'pageSize'             => 'pageSize',
        'processName'          => 'processName',
        'productCode'          => 'productCode',
        'productName'          => 'productName',
        'productSpecification' => 'productSpecification',
        'qualifiedQuantity'    => 'qualifiedQuantity',
        'unitPrice'            => 'unitPrice',
        'userId'               => 'userId',
        'userIdList'           => 'userIdList',
        'userName'             => 'userName',
        'uuid'                 => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentPage) {
            $res['currentPage'] = $this->currentPage;
        }
        if (null !== $this->instNo) {
            $res['instNo'] = $this->instNo;
        }
        if (null !== $this->manufactureDay) {
            $res['manufactureDay'] = $this->manufactureDay;
        }
        if (null !== $this->mesAppKey) {
            $res['mesAppKey'] = $this->mesAppKey;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
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
        if (null !== $this->unitPrice) {
            $res['unitPrice'] = $this->unitPrice;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
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
        if (isset($map['currentPage'])) {
            $model->currentPage = $map['currentPage'];
        }
        if (isset($map['instNo'])) {
            $model->instNo = $map['instNo'];
        }
        if (isset($map['manufactureDay'])) {
            $model->manufactureDay = $map['manufactureDay'];
        }
        if (isset($map['mesAppKey'])) {
            $model->mesAppKey = $map['mesAppKey'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
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
        if (isset($map['unitPrice'])) {
            $model->unitPrice = $map['unitPrice'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userIdList'])) {
            $model->userIdList = $map['userIdList'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
