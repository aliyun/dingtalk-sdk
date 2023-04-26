<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureQueryJobsResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example dingdb6elngd253073ad370d8dc3ec89bb366ab
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;

    /**
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $instNo;

    /**
     * @var string
     */
    public $isBatchJob;

    /**
     * @var string
     */
    public $manufactureDate;

    /**
     * @var string
     */
    public $manufactureDay;

    /**
     * @var string
     */
    public $mesAppKey;

    /**
     * @var string
     */
    public $processName;

    /**
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @var string
     */
    public $scrappedQuantity;

    /**
     * @var string
     */
    public $unitPrice;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userIdList;

    /**
     * @var string
     */
    public $userNameList;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'corpId'            => 'corpId',
        'gmtCreate'         => 'gmtCreate',
        'gmtModified'       => 'gmtModified',
        'id'                => 'id',
        'instNo'            => 'instNo',
        'isBatchJob'        => 'isBatchJob',
        'manufactureDate'   => 'manufactureDate',
        'manufactureDay'    => 'manufactureDay',
        'mesAppKey'         => 'mesAppKey',
        'processName'       => 'processName',
        'qualifiedQuantity' => 'qualifiedQuantity',
        'scrappedQuantity'  => 'scrappedQuantity',
        'unitPrice'         => 'unitPrice',
        'userId'            => 'userId',
        'userIdList'        => 'userIdList',
        'userNameList'      => 'userNameList',
        'uuid'              => 'uuid',
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
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (null !== $this->manufactureDay) {
            $res['manufactureDay'] = $this->manufactureDay;
        }
        if (null !== $this->mesAppKey) {
            $res['mesAppKey'] = $this->mesAppKey;
        }
        if (null !== $this->processName) {
            $res['processName'] = $this->processName;
        }
        if (null !== $this->qualifiedQuantity) {
            $res['qualifiedQuantity'] = $this->qualifiedQuantity;
        }
        if (null !== $this->scrappedQuantity) {
            $res['scrappedQuantity'] = $this->scrappedQuantity;
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
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['manufactureDay'])) {
            $model->manufactureDay = $map['manufactureDay'];
        }
        if (isset($map['mesAppKey'])) {
            $model->mesAppKey = $map['mesAppKey'];
        }
        if (isset($map['processName'])) {
            $model->processName = $map['processName'];
        }
        if (isset($map['qualifiedQuantity'])) {
            $model->qualifiedQuantity = $map['qualifiedQuantity'];
        }
        if (isset($map['scrappedQuantity'])) {
            $model->scrappedQuantity = $map['scrappedQuantity'];
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
        if (isset($map['userNameList'])) {
            $model->userNameList = $map['userNameList'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
