<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models;

use AlibabaCloud\Tea\Model;

class TalentV2AddCustomTagRequest extends Model
{
    /**
     * @var int
     */
    public $sortOrder;

    /**
     * @var string
     */
    public $tagCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tagName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'sortOrder' => 'sortOrder',
        'tagCode' => 'tagCode',
        'tagName' => 'tagName',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sortOrder) {
            $res['sortOrder'] = $this->sortOrder;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TalentV2AddCustomTagRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sortOrder'])) {
            $model->sortOrder = $map['sortOrder'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
