<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRobotInOrgRequest extends Model
{
    /**
     * @example 小加
     *
     * @var string
     */
    public $brief;

    /**
     * @example 小加
     *
     * @var string
     */
    public $description;

    /**
     * @example @lALPDe7s26Bre
     *
     * @var string
     */
    public $icon;

    /**
     * @example 小加
     *
     * @var string
     */
    public $name;

    /**
     * @example 123
     *
     * @var string
     */
    public $outgoingToken;

    /**
     * @example https://*.com
     *
     * @var string
     */
    public $outgoingUrl;

    /**
     * @example @lALPDe7s26Bre
     *
     * @var string
     */
    public $previewMediaId;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'brief'          => 'brief',
        'description'    => 'description',
        'icon'           => 'icon',
        'name'           => 'name',
        'outgoingToken'  => 'outgoingToken',
        'outgoingUrl'    => 'outgoingUrl',
        'previewMediaId' => 'previewMediaId',
        'robotCode'      => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->brief) {
            $res['brief'] = $this->brief;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outgoingToken) {
            $res['outgoingToken'] = $this->outgoingToken;
        }
        if (null !== $this->outgoingUrl) {
            $res['outgoingUrl'] = $this->outgoingUrl;
        }
        if (null !== $this->previewMediaId) {
            $res['previewMediaId'] = $this->previewMediaId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRobotInOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['brief'])) {
            $model->brief = $map['brief'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outgoingToken'])) {
            $model->outgoingToken = $map['outgoingToken'];
        }
        if (isset($map['outgoingUrl'])) {
            $model->outgoingUrl = $map['outgoingUrl'];
        }
        if (isset($map['previewMediaId'])) {
            $model->previewMediaId = $map['previewMediaId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
