<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesAudioResponseBody\audioList;
use AlibabaCloud\Tea\Model;

class QueryMinutesAudioResponseBody extends Model
{
    /**
     * @var audioList[]
     */
    public $audioList;
    protected $_name = [
        'audioList' => 'audioList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->audioList) {
            $res['audioList'] = [];
            if (null !== $this->audioList && \is_array($this->audioList)) {
                $n = 0;
                foreach ($this->audioList as $item) {
                    $res['audioList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMinutesAudioResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['audioList'])) {
            if (!empty($map['audioList'])) {
                $model->audioList = [];
                $n                = 0;
                foreach ($map['audioList'] as $item) {
                    $model->audioList[$n++] = null !== $item ? audioList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
