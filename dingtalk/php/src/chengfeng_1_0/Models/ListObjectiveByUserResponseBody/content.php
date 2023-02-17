<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListObjectiveByUserResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\OpenObjectiveDTO;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 总数
     *
     * @var int
     */
    public $count;

    /**
     * @var OpenObjectiveDTO[]
     */
    public $objectives;
    protected $_name = [
        'count'      => 'count',
        'objectives' => 'objectives',
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
        if (null !== $this->objectives) {
            $res['objectives'] = [];
            if (null !== $this->objectives && \is_array($this->objectives)) {
                $n = 0;
                foreach ($this->objectives as $item) {
                    $res['objectives'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['objectives'])) {
            if (!empty($map['objectives'])) {
                $model->objectives = [];
                $n                 = 0;
                foreach ($map['objectives'] as $item) {
                    $model->objectives[$n++] = null !== $item ? OpenObjectiveDTO::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
