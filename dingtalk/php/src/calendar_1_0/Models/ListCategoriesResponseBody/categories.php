<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCategoriesResponseBody;

use AlibabaCloud\Tea\Model;

class categories extends Model
{
    /**
     * @var string
     */
    public $displayName;

    /**
     * @var string
     */
    public $openCategoryId;
    protected $_name = [
        'displayName' => 'displayName',
        'openCategoryId' => 'openCategoryId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->openCategoryId) {
            $res['openCategoryId'] = $this->openCategoryId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categories
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['openCategoryId'])) {
            $model->openCategoryId = $map['openCategoryId'];
        }

        return $model;
    }
}
