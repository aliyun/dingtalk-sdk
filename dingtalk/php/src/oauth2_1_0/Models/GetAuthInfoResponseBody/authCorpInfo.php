<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody;

use AlibabaCloud\Tea\Model;

class authCorpInfo extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $authChannel;

    /**
     * @example 1
     *
     * @var string
     */
    public $authChannelType;

    /**
     * @example 1
     *
     * @var int
     */
    public $authLevel;

    /**
     * @example https://static-legacy.dingtalk.com/xxx
     *
     * @var string
     */
    public $corpLogoUrl;

    /**
     * @example 小程序体验HTTP
     *
     * @var string
     */
    public $corpName;

    /**
     * @example 201
     *
     * @var string
     */
    public $industry;

    /**
     * @example 111
     *
     * @var string
     */
    public $inviteCode;

    /**
     * @example https://wx.dingtalk.com/invite-page/xxx
     *
     * @var string
     */
    public $inviteUrl;

    /**
     * @example 111
     *
     * @var string
     */
    public $licenseCode;
    protected $_name = [
        'authChannel'     => 'authChannel',
        'authChannelType' => 'authChannelType',
        'authLevel'       => 'authLevel',
        'corpLogoUrl'     => 'corpLogoUrl',
        'corpName'        => 'corpName',
        'industry'        => 'industry',
        'inviteCode'      => 'inviteCode',
        'inviteUrl'       => 'inviteUrl',
        'licenseCode'     => 'licenseCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authChannel) {
            $res['authChannel'] = $this->authChannel;
        }
        if (null !== $this->authChannelType) {
            $res['authChannelType'] = $this->authChannelType;
        }
        if (null !== $this->authLevel) {
            $res['authLevel'] = $this->authLevel;
        }
        if (null !== $this->corpLogoUrl) {
            $res['corpLogoUrl'] = $this->corpLogoUrl;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->inviteCode) {
            $res['inviteCode'] = $this->inviteCode;
        }
        if (null !== $this->inviteUrl) {
            $res['inviteUrl'] = $this->inviteUrl;
        }
        if (null !== $this->licenseCode) {
            $res['licenseCode'] = $this->licenseCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return authCorpInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authChannel'])) {
            $model->authChannel = $map['authChannel'];
        }
        if (isset($map['authChannelType'])) {
            $model->authChannelType = $map['authChannelType'];
        }
        if (isset($map['authLevel'])) {
            $model->authLevel = $map['authLevel'];
        }
        if (isset($map['corpLogoUrl'])) {
            $model->corpLogoUrl = $map['corpLogoUrl'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['inviteCode'])) {
            $model->inviteCode = $map['inviteCode'];
        }
        if (isset($map['inviteUrl'])) {
            $model->inviteUrl = $map['inviteUrl'];
        }
        if (isset($map['licenseCode'])) {
            $model->licenseCode = $map['licenseCode'];
        }

        return $model;
    }
}
