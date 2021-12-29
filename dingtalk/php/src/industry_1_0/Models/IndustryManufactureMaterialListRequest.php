<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureMaterialListRequest extends Model
{
    /**
     * @var int
     */
    public $tokenGrantType;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $materialNo;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var int
     */
    public $microappAgentId;

    /**
     * @var int
     */
    public $cursor;

    /**
     * @var string
     */
    public $appName;

    /**
     * @var int
     */
    public $orgId;

    /**
     * @var int
     */
    public $appId;

    /**
     * @var string
     */
    public $suiteKey;

    /**
     * @var int[]
     */
    public $appIds;

    /**
     * @var int
     */
    public $currentPage;

    /**
     * @var int
     */
    public $isvOrgId;
    protected $_name = [
        'tokenGrantType'  => 'tokenGrantType',
        'corpId'          => 'corpId',
        'pageSize'        => 'pageSize',
        'endTime'         => 'endTime',
        'instanceId'      => 'instanceId',
        'materialNo'      => 'materialNo',
        'startTime'       => 'startTime',
        'microappAgentId' => 'microappAgentId',
        'cursor'          => 'cursor',
        'appName'         => 'appName',
        'orgId'           => 'orgId',
        'appId'           => 'appId',
        'suiteKey'        => 'suiteKey',
        'appIds'          => 'appIds',
        'currentPage'     => 'currentPage',
        'isvOrgId'        => 'isvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tokenGrantType) {
            $res['tokenGrantType'] = $this->tokenGrantType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->materialNo) {
            $res['materialNo'] = $this->materialNo;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->microappAgentId) {
            $res['microappAgentId'] = $this->microappAgentId;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->suiteKey) {
            $res['suiteKey'] = $this->suiteKey;
        }
        if (null !== $this->appIds) {
            $res['appIds'] = $this->appIds;
        }
        if (null !== $this->currentPage) {
            $res['currentPage'] = $this->currentPage;
        }
        if (null !== $this->isvOrgId) {
            $res['isvOrgId'] = $this->isvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMaterialListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tokenGrantType'])) {
            $model->tokenGrantType = $map['tokenGrantType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['materialNo'])) {
            $model->materialNo = $map['materialNo'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['microappAgentId'])) {
            $model->microappAgentId = $map['microappAgentId'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['suiteKey'])) {
            $model->suiteKey = $map['suiteKey'];
        }
        if (isset($map['appIds'])) {
            if (!empty($map['appIds'])) {
                $model->appIds = $map['appIds'];
            }
        }
        if (isset($map['currentPage'])) {
            $model->currentPage = $map['currentPage'];
        }
        if (isset($map['isvOrgId'])) {
            $model->isvOrgId = $map['isvOrgId'];
        }

        return $model;
    }
}
