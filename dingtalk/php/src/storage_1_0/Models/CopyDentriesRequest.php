<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentriesRequest\option;
use AlibabaCloud\Tea\Model;

class CopyDentriesRequest extends Model
{
    /**
     * @var string[]
     */
    public $dentryIds;

    /**
     * @var option
     */
    public $option;

    /**
     * @example target_folder_id
     *
     * @var string
     */
    public $targetFolderId;

    /**
     * @example target_space_id
     *
     * @var string
     */
    public $targetSpaceId;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'dentryIds'      => 'dentryIds',
        'option'         => 'option',
        'targetFolderId' => 'targetFolderId',
        'targetSpaceId'  => 'targetSpaceId',
        'unionId'        => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryIds) {
            $res['dentryIds'] = $this->dentryIds;
        }
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->targetFolderId) {
            $res['targetFolderId'] = $this->targetFolderId;
        }
        if (null !== $this->targetSpaceId) {
            $res['targetSpaceId'] = $this->targetSpaceId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyDentriesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryIds'])) {
            if (!empty($map['dentryIds'])) {
                $model->dentryIds = $map['dentryIds'];
            }
        }
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['targetFolderId'])) {
            $model->targetFolderId = $map['targetFolderId'];
        }
        if (isset($map['targetSpaceId'])) {
            $model->targetSpaceId = $map['targetSpaceId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
