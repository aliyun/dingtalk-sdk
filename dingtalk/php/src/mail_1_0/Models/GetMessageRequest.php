<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMessageRequest extends Model
{
    /**
     * @var string
     */
    public $selectFields;
    protected $_name = [
        'selectFields' => 'selectFields',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->selectFields) {
            $res['selectFields'] = $this->selectFields;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['selectFields'])) {
            $model->selectFields = $map['selectFields'];
        }

        return $model;
    }
}
