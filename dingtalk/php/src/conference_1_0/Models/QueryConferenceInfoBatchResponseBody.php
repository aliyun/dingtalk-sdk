<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponseBody\infos;
use AlibabaCloud\Tea\Model;

class QueryConferenceInfoBatchResponseBody extends Model
{
    /**
     * @description 会议详情列表
     *
     * @var infos[]
     */
    public $infos;
    protected $_name = [
        'infos' => 'infos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->infos) {
            $res['infos'] = [];
            if (null !== $this->infos && \is_array($this->infos)) {
                $n = 0;
                foreach ($this->infos as $item) {
                    $res['infos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryConferenceInfoBatchResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['infos'])) {
            if (!empty($map['infos'])) {
                $model->infos = [];
                $n            = 0;
                foreach ($map['infos'] as $item) {
                    $model->infos[$n++] = null !== $item ? infos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
