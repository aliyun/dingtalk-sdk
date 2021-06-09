<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\ParseMsgToDingTypeResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description subType
     *
     * @var string
     */
    public $subType;

    /**
     * @description extra
     *
     * @var string
     */
    public $extra;

    /**
     * @description content
     *
     * @var string
     */
    public $content;

    /**
     * @description msgType
     *
     * @var string
     */
    public $msgType;
    protected $_name = [
        'subType' => 'subType',
        'extra'   => 'extra',
        'content' => 'content',
        'msgType' => 'msgType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->extra) {
            $res['extra'] = $this->extra;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['extra'])) {
            $model->extra = $map['extra'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }

        return $model;
    }
}
