<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureCostRecordListGetRequest extends Model
{
    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $materialNo;

    /**
     * @var string
     */
    public $orderNo;

    /**
     * @var string
     */
    public $productionTaskNo;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var int
     */
    public $cursor;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var int
     */
    public $tokenGrantType;

    /**
     * @var int
     */
    public $orgId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $isvOrgId;

    /**
     * @var string
     */
    public $suiteKey;

    /**
     * @var int
     */
    public $microappAgentId;

    /**
     * @var int[]
     */
    public $appIds;

    /**
     * @var int
     */
    public $appId;

    /**
     * @var string
     */
    public $appName;
    protected $_name = [
        'instanceId'       => 'instanceId',
        'materialNo'       => 'materialNo',
        'orderNo'          => 'orderNo',
        'productionTaskNo' => 'productionTaskNo',
        'startTime'        => 'startTime',
        'endTime'          => 'endTime',
        'cursor'           => 'cursor',
        'pageNumber'       => 'pageNumber',
        'pageSize'         => 'pageSize',
        'tokenGrantType'   => 'tokenGrantType',
        'orgId'            => 'orgId',
        'corpId'           => 'corpId',
        'isvOrgId'         => 'isvOrgId',
        'suiteKey'         => 'suiteKey',
        'microappAgentId'  => 'microappAgentId',
        'appIds'           => 'appIds',
        'appId'            => 'appId',
        'appName'          => 'appName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->productionTaskNo) {
            $res['productionTaskNo'] = $this->productionTaskNo;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->tokenGrantType) {
            $res['tokenGrantType'] = $this->tokenGrantType;
        }
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvOrgId) {
            $res['isvOrgId'] = $this->isvOrgId;
        }
        if (null !== $this->suiteKey) {
            $res['suiteKey'] = $this->suiteKey;
        }
        if (null !== $this->microappAgentId) {
            $res['microappAgentId'] = $this->microappAgentId;
        }
        if (null !== $this->appIds) {
            $res['appIds'] = $this->appIds;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureCostRecordListGetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['productionTaskNo'])) {
            $model->productionTaskNo = $map['productionTaskNo'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['tokenGrantType'])) {
            $model->tokenGrantType = $map['tokenGrantType'];
        }
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['isvOrgId'])) {
            $model->isvOrgId = $map['isvOrgId'];
        }
        if (isset($map['suiteKey'])) {
            $model->suiteKey = $map['suiteKey'];
        }
        if (isset($map['microappAgentId'])) {
            $model->microappAgentId = $map['microappAgentId'];
        }
        if (isset($map['appIds'])) {
            if (!empty($map['appIds'])) {
                $model->appIds = $map['appIds'];
            }
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }

        return $model;
    }
}
