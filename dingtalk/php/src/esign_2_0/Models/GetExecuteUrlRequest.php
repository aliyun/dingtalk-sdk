<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetExecuteUrlRequest extends Model
{
    /**
     * @var string
     */
    public $taskId;

    /**
     * @var int
     */
    public $signContainer;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $account;
    protected $_name = [
        'taskId'        => 'taskId',
        'signContainer' => 'signContainer',
        'dingCorpId'    => 'dingCorpId',
        'account'       => 'account',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->signContainer) {
            $res['signContainer'] = $this->signContainer;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->account) {
            $res['account'] = $this->account;
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
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['signContainer'])) {
            $model->signContainer = $map['signContainer'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['account'])) {
            $model->account = $map['account'];
        }

        return $model;
    }
}
