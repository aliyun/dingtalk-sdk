<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendOTOInteractiveCardResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example xxxxxx
     *
     * @var string
     */
    public $processQueryKey;
    protected $_name = [
        'processQueryKey' => 'processQueryKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->processQueryKey) {
            $res['processQueryKey'] = $this->processQueryKey;
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
        if (isset($map['processQueryKey'])) {
            $model->processQueryKey = $map['processQueryKey'];
        }

        return $model;
    }
}
