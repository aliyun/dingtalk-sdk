<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetWordCloudResponseBody\words;
use AlibabaCloud\Tea\Model;

class GetWordCloudResponseBody extends Model
{
    /**
     * @description 词列表
     *
     * @var words[]
     */
    public $words;
    protected $_name = [
        'words' => 'words',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->words) {
            $res['words'] = [];
            if (null !== $this->words && \is_array($this->words)) {
                $n = 0;
                foreach ($this->words as $item) {
                    $res['words'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWordCloudResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['words'])) {
            if (!empty($map['words'])) {
                $model->words = [];
                $n            = 0;
                foreach ($map['words'] as $item) {
                    $model->words[$n++] = null !== $item ? words::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
