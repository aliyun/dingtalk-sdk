<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DingTalkSecurityCheckRequest extends Model
{
    /**
     * @description 加密字符
     *
     * @var string
     */
    public $sec;

    /**
     * @description 客户端平台类型(iOS,Android)
     *
     * @var string
     */
    public $platform;

    /**
     * @description 客户端版本号
     *
     * @var string
     */
    public $clientVer;

    /**
     * @description 客户端平台平台版本
     *
     * @var string
     */
    public $platformVer;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;
    protected $_name = [
        'sec'                => 'sec',
        'platform'           => 'platform',
        'clientVer'          => 'clientVer',
        'platformVer'        => 'platformVer',
        'userId'             => 'userId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingCorpId'         => 'dingCorpId',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sec) {
            $res['sec'] = $this->sec;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->clientVer) {
            $res['clientVer'] = $this->clientVer;
        }
        if (null !== $this->platformVer) {
            $res['platformVer'] = $this->platformVer;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DingTalkSecurityCheckRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sec'])) {
            $model->sec = $map['sec'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['clientVer'])) {
            $model->clientVer = $map['clientVer'];
        }
        if (isset($map['platformVer'])) {
            $model->platformVer = $map['platformVer'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
