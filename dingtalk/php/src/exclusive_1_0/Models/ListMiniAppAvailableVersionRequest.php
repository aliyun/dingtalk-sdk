<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListMiniAppAvailableVersionRequest extends Model
{
    /**
     * @description 版本类型列表，0-开发版，1-灰度版，2-发布版，3-体验版
     *
     * @var int[]
     */
    public $versionTypeSet;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 分页数1
     *
     * @var int
     */
    public $pageNumber;

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

    /**
     * @description 小程序id
     *
     * @var string
     */
    public $miniAppId;
    protected $_name = [
        'versionTypeSet'     => 'versionTypeSet',
        'pageSize'           => 'pageSize',
        'pageNumber'         => 'pageNumber',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingCorpId'         => 'dingCorpId',
        'dingClientId'       => 'dingClientId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'miniAppId'          => 'miniAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->versionTypeSet) {
            $res['versionTypeSet'] = $this->versionTypeSet;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
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
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListMiniAppAvailableVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['versionTypeSet'])) {
            if (!empty($map['versionTypeSet'])) {
                $model->versionTypeSet = $map['versionTypeSet'];
            }
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
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
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }

        return $model;
    }
}
