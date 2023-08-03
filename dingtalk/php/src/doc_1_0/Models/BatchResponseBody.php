<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchResponseBody extends Model
{
    /**
     * @var mixed[]
     */
    public $responses;
    protected $_name = [
        'responses' => 'responses',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->responses) {
            $res['responses'] = $this->responses;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['responses'])) {
            if (!empty($map['responses'])) {
                $model->responses = $map['responses'];
            }
        }

        return $model;
    }
}
