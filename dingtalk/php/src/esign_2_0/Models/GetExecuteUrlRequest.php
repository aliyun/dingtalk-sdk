<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetExecuteUrlRequest extends Model
{
    /**
     * @var string
     */
    public $account;

    /**
     * @var int
     */
    public $signContainer;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'account'       => 'account',
        'signContainer' => 'signContainer',
        'taskId'        => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->account) {
            $res['account'] = $this->account;
        }
        if (null !== $this->signContainer) {
            $res['signContainer'] = $this->signContainer;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetExecuteUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['account'])) {
            $model->account = $map['account'];
        }
        if (isset($map['signContainer'])) {
            $model->signContainer = $map['signContainer'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
