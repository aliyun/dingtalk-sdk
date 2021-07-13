<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAvaiableVersionRequest extends Model
{
    /**
     * @var string
     */
    public $miniAppId;

    /**
     * @var int[]
     */
    public $versionTypeSet;

    /**
     * @var string
     */
    public $bundleId;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var int
     */
    public $pageNum;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $dingClientId;

    /**
     * @var int
     */
    public $dingTokenGrantType;
    protected $_name = [
        'miniAppId'          => 'miniAppId',
        'versionTypeSet'     => 'versionTypeSet',
        'bundleId'           => 'bundleId',
        'pageSize'           => 'pageSize',
        'pageNum'            => 'pageNum',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingCorpId'         => 'dingCorpId',
        'dingClientId'       => 'dingClientId',
        'dingTokenGrantType' => 'dingTokenGrantType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->versionTypeSet) {
            $res['versionTypeSet'] = $this->versionTypeSet;
        }
        if (null !== $this->bundleId) {
            $res['bundleId'] = $this->bundleId;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->pageNum) {
            $res['pageNum'] = $this->pageNum;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAvaiableVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['versionTypeSet'])) {
            if (!empty($map['versionTypeSet'])) {
                $model->versionTypeSet = $map['versionTypeSet'];
            }
        }
        if (isset($map['bundleId'])) {
            $model->bundleId = $map['bundleId'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageNum'])) {
            $model->pageNum = $map['pageNum'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }

        return $model;
    }
}
