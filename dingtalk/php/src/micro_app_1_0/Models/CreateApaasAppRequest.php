<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateApaasAppRequest extends Model
{
    /**
     * @var string
     */
    public $appDesc;

    /**
     * @var string
     */
    public $appIcon;

    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $bizAppId;

    /**
     * @var string
     */
    public $homepageEditLink;

    /**
     * @var string
     */
    public $homepageLink;

    /**
     * @var int
     */
    public $isShortCut;

    /**
     * @var string
     */
    public $ompLink;

    /**
     * @var string
     */
    public $opUserId;

    /**
     * @var string
     */
    public $pcHomepageEditLink;

    /**
     * @var string
     */
    public $pcHomepageLink;

    /**
     * @var string
     */
    public $templateKey;
    protected $_name = [
        'appDesc'            => 'appDesc',
        'appIcon'            => 'appIcon',
        'appName'            => 'appName',
        'bizAppId'           => 'bizAppId',
        'homepageEditLink'   => 'homepageEditLink',
        'homepageLink'       => 'homepageLink',
        'isShortCut'         => 'isShortCut',
        'ompLink'            => 'ompLink',
        'opUserId'           => 'opUserId',
        'pcHomepageEditLink' => 'pcHomepageEditLink',
        'pcHomepageLink'     => 'pcHomepageLink',
        'templateKey'        => 'templateKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appDesc) {
            $res['appDesc'] = $this->appDesc;
        }
        if (null !== $this->appIcon) {
            $res['appIcon'] = $this->appIcon;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->bizAppId) {
            $res['bizAppId'] = $this->bizAppId;
        }
        if (null !== $this->homepageEditLink) {
            $res['homepageEditLink'] = $this->homepageEditLink;
        }
        if (null !== $this->homepageLink) {
            $res['homepageLink'] = $this->homepageLink;
        }
        if (null !== $this->isShortCut) {
            $res['isShortCut'] = $this->isShortCut;
        }
        if (null !== $this->ompLink) {
            $res['ompLink'] = $this->ompLink;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->pcHomepageEditLink) {
            $res['pcHomepageEditLink'] = $this->pcHomepageEditLink;
        }
        if (null !== $this->pcHomepageLink) {
            $res['pcHomepageLink'] = $this->pcHomepageLink;
        }
        if (null !== $this->templateKey) {
            $res['templateKey'] = $this->templateKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateApaasAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appDesc'])) {
            $model->appDesc = $map['appDesc'];
        }
        if (isset($map['appIcon'])) {
            $model->appIcon = $map['appIcon'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['bizAppId'])) {
            $model->bizAppId = $map['bizAppId'];
        }
        if (isset($map['homepageEditLink'])) {
            $model->homepageEditLink = $map['homepageEditLink'];
        }
        if (isset($map['homepageLink'])) {
            $model->homepageLink = $map['homepageLink'];
        }
        if (isset($map['isShortCut'])) {
            $model->isShortCut = $map['isShortCut'];
        }
        if (isset($map['ompLink'])) {
            $model->ompLink = $map['ompLink'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['pcHomepageEditLink'])) {
            $model->pcHomepageEditLink = $map['pcHomepageEditLink'];
        }
        if (isset($map['pcHomepageLink'])) {
            $model->pcHomepageLink = $map['pcHomepageLink'];
        }
        if (isset($map['templateKey'])) {
            $model->templateKey = $map['templateKey'];
        }

        return $model;
    }
}
