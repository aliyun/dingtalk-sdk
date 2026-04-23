<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryPersonalityTagResponseBody\result;

use AlibabaCloud\Tea\Model;

class tags extends Model
{
    /**
     * @var string
     */
    public $categoryCode;

    /**
     * @var string
     */
    public $categoryName;

    /**
     * @var int
     */
    public $categorySortOrder;

    /**
     * @var int
     */
    public $sortOrder;

    /**
     * @var string
     */
    public $tagCode;

    /**
     * @var string
     */
    public $tagName;
    protected $_name = [
        'categoryCode' => 'categoryCode',
        'categoryName' => 'categoryName',
        'categorySortOrder' => 'categorySortOrder',
        'sortOrder' => 'sortOrder',
        'tagCode' => 'tagCode',
        'tagName' => 'tagName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryCode) {
            $res['categoryCode'] = $this->categoryCode;
        }
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
        }
        if (null !== $this->categorySortOrder) {
            $res['categorySortOrder'] = $this->categorySortOrder;
        }
        if (null !== $this->sortOrder) {
            $res['sortOrder'] = $this->sortOrder;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tags
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryCode'])) {
            $model->categoryCode = $map['categoryCode'];
        }
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['categorySortOrder'])) {
            $model->categorySortOrder = $map['categorySortOrder'];
        }
        if (isset($map['sortOrder'])) {
            $model->sortOrder = $map['sortOrder'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }

        return $model;
    }
}
