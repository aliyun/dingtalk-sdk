<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureQueryJobsResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 工人工号(isBatchJob=='n'时)
     *
     * @var string
     */
    public $userId;

    /**
     * @description 报工记录的唯一标识
     *
     * @var string
     */
    public $uuid;

    /**
     * @description 分配给mes系统的appkey
     *
     * @var string
     */
    public $mesAppKey;

    /**
     * @description 生产日期时间(到时分秒),格式:2021-07-05 08:00:21
     *
     * @var string
     */
    public $manufactureDate;

    /**
     * @description 生产日期(到天)
     *
     * @var string
     */
    public $manufactureDay;

    /**
     * @description 工单id
     *
     * @var string
     */
    public $instNo;

    /**
     * @description 批量报工时多个人钉钉工号以英文逗号分隔
     *
     * @var string
     */
    public $userIdList;

    /**
     * @description 批量报工时多个人名以英文逗号分隔
     *
     * @var string
     */
    public $userNameList;

    /**
     * @description 计件单价，单位：分
     *
     * @var string
     */
    public $unitPrice;

    /**
     * @description 工序名称
     *
     * @var string
     */
    public $processName;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 合格数
     *
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @description 数据库id
     *
     * @var int
     */
    public $id;

    /**
     * @description 是否是批量报工，即一次报工由多个工人一起分担，取值[n,y],y表示是批量，批量时多个人名以英文逗号分隔
     *
     * @var string
     */
    public $isBatchJob;

    /**
     * @description 不合格数
     *
     * @var string
     */
    public $scrappedQuantity;
    protected $_name = [
        'corpId'            => 'corpId',
        'userId'            => 'userId',
        'uuid'              => 'uuid',
        'mesAppKey'         => 'mesAppKey',
        'manufactureDate'   => 'manufactureDate',
        'manufactureDay'    => 'manufactureDay',
        'instNo'            => 'instNo',
        'userIdList'        => 'userIdList',
        'userNameList'      => 'userNameList',
        'unitPrice'         => 'unitPrice',
        'processName'       => 'processName',
        'gmtModified'       => 'gmtModified',
        'gmtCreate'         => 'gmtCreate',
        'qualifiedQuantity' => 'qualifiedQuantity',
        'id'                => 'id',
        'isBatchJob'        => 'isBatchJob',
        'scrappedQuantity'  => 'scrappedQuantity',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->mesAppKey) {
            $res['mesAppKey'] = $this->mesAppKey;
        }
        if (null !== $this->manufactureDate) {
            $res['manufactureDate'] = $this->manufactureDate;
        }
        if (null !== $this->manufactureDay) {
            $res['manufactureDay'] = $this->manufactureDay;
        }
        if (null !== $this->instNo) {
            $res['instNo'] = $this->instNo;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->userNameList) {
            $res['userNameList'] = $this->userNameList;
        }
        if (null !== $this->unitPrice) {
            $res['unitPrice'] = $this->unitPrice;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->qualifiedQuantity) {
            $res['qualifiedQuantity'] = $this->qualifiedQuantity;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isBatchJob) {
            $res['isBatchJob'] = $this->isBatchJob;
        }
        if (null !== $this->scrappedQuantity) {
            $res['scrappedQuantity'] = $this->scrappedQuantity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['mesAppKey'])) {
            $model->mesAppKey = $map['mesAppKey'];
        }
        if (isset($map['manufactureDate'])) {
            $model->manufactureDate = $map['manufactureDate'];
        }
        if (isset($map['manufactureDay'])) {
            $model->manufactureDay = $map['manufactureDay'];
        }
        if (isset($map['instNo'])) {
            $model->instNo = $map['instNo'];
        }
        if (isset($map['userIdList'])) {
            $model->userIdList = $map['userIdList'];
        }
        if (isset($map['userNameList'])) {
            $model->userNameList = $map['userNameList'];
        }
        if (isset($map['unitPrice'])) {
            $model->unitPrice = $map['unitPrice'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['qualifiedQuantity'])) {
            $model->qualifiedQuantity = $map['qualifiedQuantity'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isBatchJob'])) {
            $model->isBatchJob = $map['isBatchJob'];
        }
        if (isset($map['scrappedQuantity'])) {
            $model->scrappedQuantity = $map['scrappedQuantity'];
        }

        return $model;
    }
}
