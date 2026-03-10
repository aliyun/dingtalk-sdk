<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListOrgPluginsHeaders extends Model
{
    public $commonHeaders;

    /**
     * @var string
     */
    public $dingAccessTokenType;

    /**
     * @var string
     */
    public $dingClientId;

    /**
     * @var string
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingOpenAppOrgId;

    /**
     * @var string
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var string
     */
    public $xAcsDingtalkAccessToken;
    protected $_name = [
        'dingAccessTokenType' => 'dingAccessTokenType',
        'dingClientId' => 'dingClientId',
        'dingIsvOrgId' => 'dingIsvOrgId',
        'dingOpenAppOrgId' => 'dingOpenAppOrgId',
        'dingOrgId' => 'dingOrgId',
        'dingSuiteKey' => 'dingSuiteKey',
        'xAcsDingtalkAccessToken' => 'x-acs-dingtalk-access-token',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commonHeaders) {
            $res['commonHeaders'] = $this->commonHeaders;
        }
        if (null !== $this->dingAccessTokenType) {
            $res['dingAccessTokenType'] = $this->dingAccessTokenType;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOpenAppOrgId) {
            $res['dingOpenAppOrgId'] = $this->dingOpenAppOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->xAcsDingtalkAccessToken) {
            $res['x-acs-dingtalk-access-token'] = $this->xAcsDingtalkAccessToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListOrgPluginsHeaders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commonHeaders'])) {
            $model->commonHeaders = $map['commonHeaders'];
        }
        if (isset($map['dingAccessTokenType'])) {
            $model->dingAccessTokenType = $map['dingAccessTokenType'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOpenAppOrgId'])) {
            $model->dingOpenAppOrgId = $map['dingOpenAppOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['x-acs-dingtalk-access-token'])) {
            $model->xAcsDingtalkAccessToken = $map['x-acs-dingtalk-access-token'];
        }

        return $model;
    }
}
