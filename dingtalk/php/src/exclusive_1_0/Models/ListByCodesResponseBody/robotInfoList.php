<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListByCodesResponseBody;

use AlibabaCloud\Tea\Model;

class robotInfoList extends Model
{
    /**
     * @var string
     */
    public $brief;

    /**
     * @var string
     */
    public $code;

    /**
     * @var int
     */
    public $createAt;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $dev;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var int
     */
    public $modifiedAt;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $outgoingToken;

    /**
     * @var string
     */
    public $outgoingUrl;

    /**
     * @var string
     */
    public $previewMediaId;

    /**
     * @var string
     */
    public $sourceUrl;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'brief'          => 'brief',
        'code'           => 'code',
        'createAt'       => 'createAt',
        'description'    => 'description',
        'dev'            => 'dev',
        'icon'           => 'icon',
        'modifiedAt'     => 'modifiedAt',
        'name'           => 'name',
        'outgoingToken'  => 'outgoingToken',
        'outgoingUrl'    => 'outgoingUrl',
        'previewMediaId' => 'previewMediaId',
        'sourceUrl'      => 'sourceUrl',
        'status'         => 'status',
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
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->dev) {
            $res['dev'] = $this->dev;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->modifiedAt) {
            $res['modifiedAt'] = $this->modifiedAt;
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
        if (null !== $this->sourceUrl) {
            $res['sourceUrl'] = $this->sourceUrl;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return robotInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['brief'])) {
            $model->brief = $map['brief'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['dev'])) {
            $model->dev = $map['dev'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['modifiedAt'])) {
            $model->modifiedAt = $map['modifiedAt'];
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
        if (isset($map['sourceUrl'])) {
            $model->sourceUrl = $map['sourceUrl'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
