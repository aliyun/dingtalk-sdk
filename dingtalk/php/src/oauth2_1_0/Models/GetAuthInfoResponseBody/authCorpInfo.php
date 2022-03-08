<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody;

use AlibabaCloud\Tea\Model;

class authCorpInfo extends Model
{
    /**
     * @description 渠道码。
     *
     * @var string
     */
    public $authChannel;

    /**
     * @description 渠道类型。  为了避免渠道码重复，可与渠道码共同确认渠道。可能为空，非空时当前只有满天星类型，值为STAR_ACTIVITY。
     *
     * @var string
     */
    public $authChannelType;

    /**
     * @description 企业认证等级：  0：未认证  1：高级认证  2：中级认证  3：初级认证
     *
     * @var int
     */
    public $authLevel;

    /**
     * @description 企业logo。
     *
     * @var string
     */
    public $corpLogoUrl;

    /**
     * @description 授权方企业名称。
     *
     * @var string
     */
    public $corpName;

    /**
     * @description 企业所属行业。
     *
     * @var string
     */
    public $industry;

    /**
     * @description 邀请码，只有自己邀请的企业才会返回邀请码，可用该邀请码统计不同渠道的拉新，否则值为空字符串。
     *
     * @var string
     */
    public $inviteCode;

    /**
     * @description 企业邀请链接。
     *
     * @var string
     */
    public $inviteUrl;

    /**
     * @description 序列号。
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
