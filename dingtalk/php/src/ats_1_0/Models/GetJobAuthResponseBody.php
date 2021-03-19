<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobAuthResponseBody\jobOwners;
use AlibabaCloud\Tea\Model;

class GetJobAuthResponseBody extends Model
{
    /**
     * @description 职位ID
     *
     * @var string
     */
    public $jobId;

    /**
     * @description 职位负责人
     *
     * @var jobOwners[]
     */
    public $jobOwners;
    protected $_name = [
        'jobId'     => 'jobId',
        'jobOwners' => 'jobOwners',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }
        if (null !== $this->jobOwners) {
            $res['jobOwners'] = [];
            if (null !== $this->jobOwners && \is_array($this->jobOwners)) {
                $n = 0;
                foreach ($this->jobOwners as $item) {
                    $res['jobOwners'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetJobAuthResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }
        if (isset($map['jobOwners'])) {
            if (!empty($map['jobOwners'])) {
                $model->jobOwners = [];
                $n                = 0;
                foreach ($map['jobOwners'] as $item) {
                    $model->jobOwners[$n++] = null !== $item ? jobOwners::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
