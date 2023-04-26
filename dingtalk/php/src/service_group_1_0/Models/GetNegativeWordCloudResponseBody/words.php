<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetNegativeWordCloudResponseBody;

use AlibabaCloud\Tea\Model;

class words extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $count;

    /**
     * @example 销售
     *
     * @var string
     */
    public $word;
    protected $_name = [
        'count' => 'count',
        'word'  => 'word',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->word) {
            $res['word'] = $this->word;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return words
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['word'])) {
            $model->word = $map['word'];
        }

        return $model;
    }
}
