<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\QueryPluginRuleResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $chatType;

    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $itemId;

    /**
     * @var string
     */
    public $itemName;

    /**
     * @var string
     */
    public $itemType;
    protected $_name = [
        'bizId' => 'bizId',
        'chatType' => 'chatType',
        'code' => 'code',
        'gmtCreate' => 'gmtCreate',
        'itemId' => 'itemId',
        'itemName' => 'itemName',
        'itemType' => 'itemType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->chatType) {
            $res['chatType'] = $this->chatType;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->itemType) {
            $res['itemType'] = $this->itemType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['chatType'])) {
            $model->chatType = $map['chatType'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['itemType'])) {
            $model->itemType = $map['itemType'];
        }

        return $model;
    }
}
