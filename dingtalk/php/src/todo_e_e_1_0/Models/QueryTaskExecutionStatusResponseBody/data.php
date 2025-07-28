<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\QueryTaskExecutionStatusResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var bool
     */
    public $done;

    /**
     * @var string
     */
    public $executorId;

    /**
     * @var int
     */
    public $finishDate;
    protected $_name = [
        'done' => 'done',
        'executorId' => 'executorId',
        'finishDate' => 'finishDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->done) {
            $res['done'] = $this->done;
        }
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }
        if (null !== $this->finishDate) {
            $res['finishDate'] = $this->finishDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['done'])) {
            $model->done = $map['done'];
        }
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['finishDate'])) {
            $model->finishDate = $map['finishDate'];
        }

        return $model;
    }
}
