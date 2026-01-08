<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainLabelMetaUpdateResponseBody extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var bool
     */
    public $result;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'content' => 'content',
        'requestId' => 'requestId',
        'result' => 'result',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainLabelMetaUpdateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
