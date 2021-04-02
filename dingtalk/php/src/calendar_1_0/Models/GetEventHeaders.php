<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetEventHeaders extends Model
{
    public $commonHeaders;

    /**
     * @description 授权本次调用的企业id，该字段有值时认为本次调用已被授权访问该企业下的所有数据
     *
     * @var string
     */
    public $dingOrgId;

    /**
     * @description 授权本次调用的用户id，该字段有值时认为本次调用已被授权访问该用户可以访问的所有数据
     *
     * @var string
     */
    public $dingUid;

    /**
     * @description 授权类型
     *
     * @var string
     */
    public $dingAccessTokenType;

    /**
     * @var string
     */
    public $xAcsDingtalkAccessToken;
    protected $_name = [
        'dingOrgId'               => 'dingOrgId',
        'dingUid'                 => 'dingUid',
        'dingAccessTokenType'     => 'dingAccessTokenType',
        'xAcsDingtalkAccessToken' => 'x-acs-dingtalk-access-token',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->commonHeaders) {
            $res['commonHeaders'] = $this->commonHeaders;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingUid) {
            $res['dingUid'] = $this->dingUid;
        }
        if (null !== $this->dingAccessTokenType) {
            $res['dingAccessTokenType'] = $this->dingAccessTokenType;
        }
        if (null !== $this->xAcsDingtalkAccessToken) {
            $res['x-acs-dingtalk-access-token'] = $this->xAcsDingtalkAccessToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEventHeaders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commonHeaders'])) {
            $model->commonHeaders = $map['commonHeaders'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingUid'])) {
            $model->dingUid = $map['dingUid'];
        }
        if (isset($map['dingAccessTokenType'])) {
            $model->dingAccessTokenType = $map['dingAccessTokenType'];
        }
        if (isset($map['x-acs-dingtalk-access-token'])) {
            $model->xAcsDingtalkAccessToken = $map['x-acs-dingtalk-access-token'];
        }

        return $model;
    }
}
