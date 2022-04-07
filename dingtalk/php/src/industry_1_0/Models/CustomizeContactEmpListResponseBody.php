<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpListResponseBody\content;
use AlibabaCloud\Tea\Model;

class CustomizeContactEmpListResponseBody extends Model
{
    /**
     * @description 人员信息列表
     *
     * @var content[]
     */
    public $content;
    protected $_name = [
        'content' => 'content',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = [];
            if (null !== $this->content && \is_array($this->content)) {
                $n = 0;
                foreach ($this->content as $item) {
                    $res['content'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomizeContactEmpListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            if (!empty($map['content'])) {
                $model->content = [];
                $n              = 0;
                foreach ($map['content'] as $item) {
                    $model->content[$n++] = null !== $item ? content::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
