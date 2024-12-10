<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsModifyRequest;

use AlibabaCloud\Tea\Model;

class request extends Model
{
    /**
     * @var mixed[]
     */
    public $body;

    /**
     * @var string
     */
    public $slotId;
    protected $_name = [
        'body'   => 'body',
        'slotId' => 'slotId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }
        if (null !== $this->slotId) {
            $res['slotId'] = $this->slotId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }
        if (isset($map['slotId'])) {
            $model->slotId = $map['slotId'];
        }

        return $model;
    }
}
