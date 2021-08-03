<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetAttachsApprovalHeaders extends Model
{
    public $commonHeaders;

    /**
     * @var string
     */
    public $serviceGroup;

    /**
     * @var string
     */
    public $tsignOpenAppId;

    /**
     * @var string
     */
    public $xAcsDingtalkAccessToken;
    protected $_name = [
        'serviceGroup'            => 'serviceGroup',
        'tsignOpenAppId'          => 'tsignOpenAppId',
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
        if (null !== $this->serviceGroup) {
            $res['serviceGroup'] = $this->serviceGroup;
        }
        if (null !== $this->tsignOpenAppId) {
            $res['tsignOpenAppId'] = $this->tsignOpenAppId;
        }
        if (null !== $this->xAcsDingtalkAccessToken) {
            $res['x-acs-dingtalk-access-token'] = $this->xAcsDingtalkAccessToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAttachsApprovalHeaders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commonHeaders'])) {
            $model->commonHeaders = $map['commonHeaders'];
        }
        if (isset($map['serviceGroup'])) {
            $model->serviceGroup = $map['serviceGroup'];
        }
        if (isset($map['tsignOpenAppId'])) {
            $model->tsignOpenAppId = $map['tsignOpenAppId'];
        }
        if (isset($map['x-acs-dingtalk-access-token'])) {
            $model->xAcsDingtalkAccessToken = $map['x-acs-dingtalk-access-token'];
        }

        return $model;
    }
}
