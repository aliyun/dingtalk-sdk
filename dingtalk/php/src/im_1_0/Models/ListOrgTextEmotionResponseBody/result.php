<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionResponseBody\result\emotions;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 企业文字表情列表
     *
     * @var emotions[]
     */
    public $emotions;
    protected $_name = [
        'emotions' => 'emotions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->emotions) {
            $res['emotions'] = [];
            if (null !== $this->emotions && \is_array($this->emotions)) {
                $n = 0;
                foreach ($this->emotions as $item) {
                    $res['emotions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['emotions'])) {
            if (!empty($map['emotions'])) {
                $model->emotions = [];
                $n               = 0;
                foreach ($map['emotions'] as $item) {
                    $model->emotions[$n++] = null !== $item ? emotions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
