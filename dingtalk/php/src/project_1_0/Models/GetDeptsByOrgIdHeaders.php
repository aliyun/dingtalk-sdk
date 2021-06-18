<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDeptsByOrgIdHeaders extends Model
{
    public $commonHeaders;

    /**
     * @var string
     */
    public $dingAccessTokenType;

    /**
     * @var string
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $xAcsDingtalkAccessToken;
    protected $_name = [
        'dingAccessTokenType'     => 'dingAccessTokenType',
        'dingOrgId'               => 'dingOrgId',
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
        if (null !== $this->dingAccessTokenType) {
            $res['dingAccessTokenType'] = $this->dingAccessTokenType;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->xAcsDingtalkAccessToken) {
            $res['x-acs-dingtalk-access-token'] = $this->xAcsDingtalkAccessToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeptsByOrgIdHeaders
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
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['x-acs-dingtalk-access-token'])) {
            $model->xAcsDingtalkAccessToken = $map['x-acs-dingtalk-access-token'];
        }

        return $model;
    }
}
