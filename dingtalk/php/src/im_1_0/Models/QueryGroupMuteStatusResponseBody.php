<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusResponseBody\userMuteResult;
use AlibabaCloud\Tea\Model;

class QueryGroupMuteStatusResponseBody extends Model
{
    /**
     * @description 群禁言状态
     *
     * @var bool
     */
    public $groupMuteMode;

    /**
     * @var userMuteResult
     */
    public $userMuteResult;
    protected $_name = [
        'groupMuteMode'  => 'groupMuteMode',
        'userMuteResult' => 'userMuteResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMuteMode) {
            $res['groupMuteMode'] = $this->groupMuteMode;
        }
        if (null !== $this->userMuteResult) {
            $res['userMuteResult'] = null !== $this->userMuteResult ? $this->userMuteResult->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupMuteStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMuteMode'])) {
            $model->groupMuteMode = $map['groupMuteMode'];
        }
        if (isset($map['userMuteResult'])) {
            $model->userMuteResult = userMuteResult::fromMap($map['userMuteResult']);
        }

        return $model;
    }
}
