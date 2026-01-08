<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\OrgGroupQueryResponseBody\readUsers;
use AlibabaCloud\Tea\Model;

class OrgGroupQueryResponseBody extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @example Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var string[]
     */
    public $readUserIds;

    /**
     * @var readUsers[]
     */
    public $readUsers;

    /**
     * @example SUCCESS
     *
     * @var string
     */
    public $sendStatus;
    protected $_name = [
        'hasMore' => 'hasMore',
        'nextToken' => 'nextToken',
        'readUserIds' => 'readUserIds',
        'readUsers' => 'readUsers',
        'sendStatus' => 'sendStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->readUserIds) {
            $res['readUserIds'] = $this->readUserIds;
        }
        if (null !== $this->readUsers) {
            $res['readUsers'] = [];
            if (null !== $this->readUsers && \is_array($this->readUsers)) {
                $n = 0;
                foreach ($this->readUsers as $item) {
                    $res['readUsers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sendStatus) {
            $res['sendStatus'] = $this->sendStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrgGroupQueryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['readUserIds'])) {
            if (!empty($map['readUserIds'])) {
                $model->readUserIds = $map['readUserIds'];
            }
        }
        if (isset($map['readUsers'])) {
            if (!empty($map['readUsers'])) {
                $model->readUsers = [];
                $n = 0;
                foreach ($map['readUsers'] as $item) {
                    $model->readUsers[$n++] = null !== $item ? readUsers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sendStatus'])) {
            $model->sendStatus = $map['sendStatus'];
        }

        return $model;
    }
}
