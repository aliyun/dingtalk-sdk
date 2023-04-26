<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\BatchInsertBizObjectResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string[]
     */
    public $bizObjectIds;

    /**
     * @var string[]
     */
    public $failedDatas;

    /**
     * @var string[]
     */
    public $failedMessages;

    /**
     * @var string[]
     */
    public $processIds;
    protected $_name = [
        'bizObjectIds'   => 'bizObjectIds',
        'failedDatas'    => 'failedDatas',
        'failedMessages' => 'failedMessages',
        'processIds'     => 'processIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectIds) {
            $res['bizObjectIds'] = $this->bizObjectIds;
        }
        if (null !== $this->failedDatas) {
            $res['failedDatas'] = $this->failedDatas;
        }
        if (null !== $this->failedMessages) {
            $res['failedMessages'] = $this->failedMessages;
        }
        if (null !== $this->processIds) {
            $res['processIds'] = $this->processIds;
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
        if (isset($map['bizObjectIds'])) {
            if (!empty($map['bizObjectIds'])) {
                $model->bizObjectIds = $map['bizObjectIds'];
            }
        }
        if (isset($map['failedDatas'])) {
            if (!empty($map['failedDatas'])) {
                $model->failedDatas = $map['failedDatas'];
            }
        }
        if (isset($map['failedMessages'])) {
            if (!empty($map['failedMessages'])) {
                $model->failedMessages = $map['failedMessages'];
            }
        }
        if (isset($map['processIds'])) {
            if (!empty($map['processIds'])) {
                $model->processIds = $map['processIds'];
            }
        }

        return $model;
    }
}
