<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateInnerAppRequest extends Model
{
    /**
     * @example descxxx
     *
     * @var string
     */
    public $desc;

    /**
     * @var int
     */
    public $developType;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $homepageLink;

    /**
     * @example mediaxxx
     *
     * @var string
     */
    public $icon;

    /**
     * @var string[]
     */
    public $ipWhiteList;

    /**
     * @example namexx
     *
     * @var string
     */
    public $name;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $ompLink;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $opUnionId;

    /**
     * @example https://www.dingtalk.com
     *
     * @var string
     */
    public $pcHomepageLink;

    /**
     * @example BASE
     *
     * @var string
     */
    public $scopeType;
    protected $_name = [
        'desc'           => 'desc',
        'developType'    => 'developType',
        'homepageLink'   => 'homepageLink',
        'icon'           => 'icon',
        'ipWhiteList'    => 'ipWhiteList',
        'name'           => 'name',
        'ompLink'        => 'ompLink',
        'opUnionId'      => 'opUnionId',
        'pcHomepageLink' => 'pcHomepageLink',
        'scopeType'      => 'scopeType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->developType) {
            $res['developType'] = $this->developType;
        }
        if (null !== $this->homepageLink) {
            $res['homepageLink'] = $this->homepageLink;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->ipWhiteList) {
            $res['ipWhiteList'] = $this->ipWhiteList;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ompLink) {
            $res['ompLink'] = $this->ompLink;
        }
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }
        if (null !== $this->pcHomepageLink) {
            $res['pcHomepageLink'] = $this->pcHomepageLink;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateInnerAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['developType'])) {
            $model->developType = $map['developType'];
        }
        if (isset($map['homepageLink'])) {
            $model->homepageLink = $map['homepageLink'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['ipWhiteList'])) {
            if (!empty($map['ipWhiteList'])) {
                $model->ipWhiteList = $map['ipWhiteList'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ompLink'])) {
            $model->ompLink = $map['ompLink'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }
        if (isset($map['pcHomepageLink'])) {
            $model->pcHomepageLink = $map['pcHomepageLink'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }

        return $model;
    }
}
