<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddWorkspaceResponseBody\workspace;
use AlibabaCloud\Tea\Model;

class AddWorkspaceResponseBody extends Model
{
    /**
     * @var workspace
     */
    public $workspace;
    protected $_name = [
        'workspace' => 'workspace',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->workspace) {
            $res['workspace'] = null !== $this->workspace ? $this->workspace->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddWorkspaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workspace'])) {
            $model->workspace = workspace::fromMap($map['workspace']);
        }

        return $model;
    }
}
