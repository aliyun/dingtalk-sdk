<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddWorkspaceRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example workspace_description
     *
     * @var string
     */
    public $description;

    /**
     * @example team_id
     *
     * @var string
     */
    public $teamId;
    protected $_name = [
        'description' => 'description',
        'teamId' => 'teamId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }

        return $model;
    }
}
