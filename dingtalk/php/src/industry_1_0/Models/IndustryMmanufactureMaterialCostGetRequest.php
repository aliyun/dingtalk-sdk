<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryMmanufactureMaterialCostGetRequest extends Model
{
    /**
     * @var int
     */
    public $appId;

    /**
     * @var int[]
     */
    public $appIds;

    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $cursor;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var int
     */
    public $isvOrgId;

    /**
     * @var string
     */
    public $materialNo;

    /**
     * @var int
     */
    public $microappAgentId;

    /**
     * @var int
     */
    public $orgId;

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
    public $startTime;

    /**
     * @var string
     */
    public $suiteKey;

    /**
     * @var int
     */
    public $tokenGrantType;
    protected $_name = [
        'appId'           => 'appId',
        'appIds'          => 'appIds',
        'appName'         => 'appName',
        'corpId'          => 'corpId',
        'cursor'          => 'cursor',
        'endTime'         => 'endTime',
        'instanceId'      => 'instanceId',
        'isvOrgId'        => 'isvOrgId',
        'materialNo'      => 'materialNo',
        'microappAgentId' => 'microappAgentId',
        'orgId'           => 'orgId',
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'startTime'       => 'startTime',
        'suiteKey'        => 'suiteKey',
        'tokenGrantType'  => 'tokenGrantType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->appIds) {
            $res['appIds'] = $this->appIds;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->isvOrgId) {
            $res['isvOrgId'] = $this->isvOrgId;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->microappAgentId) {
            $res['microappAgentId'] = $this->microappAgentId;
        }
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->suiteKey) {
            $res['suiteKey'] = $this->suiteKey;
        }
        if (null !== $this->tokenGrantType) {
            $res['tokenGrantType'] = $this->tokenGrantType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryMmanufactureMaterialCostGetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['appIds'])) {
            if (!empty($map['appIds'])) {
                $model->appIds = $map['appIds'];
            }
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['isvOrgId'])) {
            $model->isvOrgId = $map['isvOrgId'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['microappAgentId'])) {
            $model->microappAgentId = $map['microappAgentId'];
        }
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['suiteKey'])) {
            $model->suiteKey = $map['suiteKey'];
        }
        if (isset($map['tokenGrantType'])) {
            $model->tokenGrantType = $map['tokenGrantType'];
        }

        return $model;
    }
}
