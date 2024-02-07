<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryConversationMessageForAIRequest extends Model
{
    /**
     * @var string[]
     */
    public $openMsgIds;

    /**
     * @var int
     */
    public $recentDays;

    /**
     * @var int
     */
    public $recentHours;

    /**
     * @var int
     */
    public $recentN;
    protected $_name = [
        'openMsgIds'  => 'openMsgIds',
        'recentDays'  => 'recentDays',
        'recentHours' => 'recentHours',
        'recentN'     => 'recentN',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openMsgIds) {
            $res['openMsgIds'] = $this->openMsgIds;
        }
        if (null !== $this->recentDays) {
            $res['recentDays'] = $this->recentDays;
        }
        if (null !== $this->recentHours) {
            $res['recentHours'] = $this->recentHours;
        }
        if (null !== $this->recentN) {
            $res['recentN'] = $this->recentN;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryConversationMessageForAIRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openMsgIds'])) {
            if (!empty($map['openMsgIds'])) {
                $model->openMsgIds = $map['openMsgIds'];
            }
        }
        if (isset($map['recentDays'])) {
            $model->recentDays = $map['recentDays'];
        }
        if (isset($map['recentHours'])) {
            $model->recentHours = $map['recentHours'];
        }
        if (isset($map['recentN'])) {
            $model->recentN = $map['recentN'];
        }

        return $model;
    }
}
