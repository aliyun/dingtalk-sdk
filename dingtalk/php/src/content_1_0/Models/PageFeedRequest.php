<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class PageFeedRequest extends Model
{
    /**
     * @var string[]
     */
    public $body;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 50730********40554
     *
     * @var string
     */
    public $mcnId;

    /**
     * @example 10
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'body'       => 'body',
        'maxResults' => 'maxResults',
        'mcnId'      => 'mcnId',
        'nextToken'  => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->mcnId) {
            $res['mcnId'] = $this->mcnId;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            if (!empty($map['body'])) {
                $model->body = $map['body'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['mcnId'])) {
            $model->mcnId = $map['mcnId'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
