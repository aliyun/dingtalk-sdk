<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\Tea\Model;

class StreamingUpdateRequest extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $guid;

    /**
     * @var bool
     */
    public $isError;

    /**
     * @var bool
     */
    public $isFinalize;

    /**
     * @var bool
     */
    public $isFull;

    /**
     * @var string
     */
    public $key;

    /**
     * @var string
     */
    public $outTrackId;
    protected $_name = [
        'content'    => 'content',
        'guid'       => 'guid',
        'isError'    => 'isError',
        'isFinalize' => 'isFinalize',
        'isFull'     => 'isFull',
        'key'        => 'key',
        'outTrackId' => 'outTrackId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->guid) {
            $res['guid'] = $this->guid;
        }
        if (null !== $this->isError) {
            $res['isError'] = $this->isError;
        }
        if (null !== $this->isFinalize) {
            $res['isFinalize'] = $this->isFinalize;
        }
        if (null !== $this->isFull) {
            $res['isFull'] = $this->isFull;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StreamingUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['guid'])) {
            $model->guid = $map['guid'];
        }
        if (isset($map['isError'])) {
            $model->isError = $map['isError'];
        }
        if (isset($map['isFinalize'])) {
            $model->isFinalize = $map['isFinalize'];
        }
        if (isset($map['isFull'])) {
            $model->isFull = $map['isFull'];
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }

        return $model;
    }
}
