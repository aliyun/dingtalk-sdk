<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateEvaluatePerformanceCountRequest\unreadData;
use AlibabaCloud\Tea\Model;

class UpdateEvaluatePerformanceCountRequest extends Model
{
    /**
     * @var string
     */
    public $teacherId;

    /**
     * @var unreadData[]
     */
    public $unreadData;
    protected $_name = [
        'teacherId' => 'teacherId',
        'unreadData' => 'unreadData',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }
        if (null !== $this->unreadData) {
            $res['unreadData'] = [];
            if (null !== $this->unreadData && \is_array($this->unreadData)) {
                $n = 0;
                foreach ($this->unreadData as $item) {
                    $res['unreadData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateEvaluatePerformanceCountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }
        if (isset($map['unreadData'])) {
            if (!empty($map['unreadData'])) {
                $model->unreadData = [];
                $n = 0;
                foreach ($map['unreadData'] as $item) {
                    $model->unreadData[$n++] = null !== $item ? unreadData::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
