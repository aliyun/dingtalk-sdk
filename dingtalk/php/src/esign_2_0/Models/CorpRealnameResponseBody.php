<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class CorpRealnameResponseBody extends Model
{
    /**
     * @var string
     */
    public $taskId;

    /**
     * @var string
     */
    public $pcUrl;

    /**
     * @var string
     */
    public $mobileUrl;
    protected $_name = [
        'taskId'    => 'taskId',
        'pcUrl'     => 'pcUrl',
        'mobileUrl' => 'mobileUrl',
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
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CorpRealnameResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }

        return $model;
    }
}
