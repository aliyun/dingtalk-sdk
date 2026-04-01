<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CleanFileResponseBody extends Model
{
    /**
     * @var int[]
     */
    public $failureIds;

    /**
     * @var int[]
     */
    public $successIds;
    protected $_name = [
        'failureIds' => 'failureIds',
        'successIds' => 'successIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failureIds) {
            $res['failureIds'] = $this->failureIds;
        }
        if (null !== $this->successIds) {
            $res['successIds'] = $this->successIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CleanFileResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failureIds'])) {
            if (!empty($map['failureIds'])) {
                $model->failureIds = $map['failureIds'];
            }
        }
        if (isset($map['successIds'])) {
            if (!empty($map['successIds'])) {
                $model->successIds = $map['successIds'];
            }
        }

        return $model;
    }
}
