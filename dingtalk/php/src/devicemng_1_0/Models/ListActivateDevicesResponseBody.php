<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesResponseBody\result;
use AlibabaCloud\Tea\Model;

class ListActivateDevicesResponseBody extends Model
{
    /**
     * @var int
     */
    public $totalCount;

    /**
     * @var bool
     */
    public $success;

    /**
     * @var result[]
     */
    public $result;
    protected $_name = [
        'totalCount' => 'totalCount',
        'success'    => 'success',
        'result'     => 'result',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->result) {
            $res['result'] = [];
            if (null !== $this->result && \is_array($this->result)) {
                $n = 0;
                foreach ($this->result as $item) {
                    $res['result'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListActivateDevicesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['result'])) {
            if (!empty($map['result'])) {
                $model->result = [];
                $n             = 0;
                foreach ($map['result'] as $item) {
                    $model->result[$n++] = null !== $item ? result::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
