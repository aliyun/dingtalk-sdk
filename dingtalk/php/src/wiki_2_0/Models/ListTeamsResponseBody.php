<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListTeamsResponseBody\teams;
use AlibabaCloud\Tea\Model;

class ListTeamsResponseBody extends Model
{
    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var teams[]
     */
    public $teams;
    protected $_name = [
        'nextToken' => 'nextToken',
        'teams' => 'teams',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->teams) {
            $res['teams'] = [];
            if (null !== $this->teams && \is_array($this->teams)) {
                $n = 0;
                foreach ($this->teams as $item) {
                    $res['teams'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListTeamsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['teams'])) {
            if (!empty($map['teams'])) {
                $model->teams = [];
                $n = 0;
                foreach ($map['teams'] as $item) {
                    $model->teams[$n++] = null !== $item ? teams::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
