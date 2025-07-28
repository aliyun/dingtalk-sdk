<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProjectRolesV3Request extends Model
{
    /**
     * @var bool
     */
    public $includeHidden;

    /**
     * @var int
     */
    public $level;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'includeHidden' => 'includeHidden',
        'level' => 'level',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->includeHidden) {
            $res['includeHidden'] = $this->includeHidden;
        }
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProjectRolesV3Request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['includeHidden'])) {
            $model->includeHidden = $map['includeHidden'];
        }
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
