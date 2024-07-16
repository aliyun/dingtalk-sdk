<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordResponseBody\createdBy;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordResponseBody\lastModifiedBy;
use AlibabaCloud\Tea\Model;

class GetRecordResponseBody extends Model
{
    /**
     * @var createdBy
     */
    public $createdBy;

    /**
     * @var int
     */
    public $createdTime;

    /**
     * @var mixed[]
     */
    public $fields;

    /**
     * @var string
     */
    public $id;

    /**
     * @var lastModifiedBy
     */
    public $lastModifiedBy;

    /**
     * @var int
     */
    public $lastModifiedTime;
    protected $_name = [
        'createdBy'        => 'createdBy',
        'createdTime'      => 'createdTime',
        'fields'           => 'fields',
        'id'               => 'id',
        'lastModifiedBy'   => 'lastModifiedBy',
        'lastModifiedTime' => 'lastModifiedTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdBy) {
            $res['createdBy'] = null !== $this->createdBy ? $this->createdBy->toMap() : null;
        }
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->fields) {
            $res['fields'] = $this->fields;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->lastModifiedBy) {
            $res['lastModifiedBy'] = null !== $this->lastModifiedBy ? $this->lastModifiedBy->toMap() : null;
        }
        if (null !== $this->lastModifiedTime) {
            $res['lastModifiedTime'] = $this->lastModifiedTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRecordResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createdBy'])) {
            $model->createdBy = createdBy::fromMap($map['createdBy']);
        }
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['fields'])) {
            $model->fields = $map['fields'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['lastModifiedBy'])) {
            $model->lastModifiedBy = lastModifiedBy::fromMap($map['lastModifiedBy']);
        }
        if (isset($map['lastModifiedTime'])) {
            $model->lastModifiedTime = $map['lastModifiedTime'];
        }

        return $model;
    }
}
